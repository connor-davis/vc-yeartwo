using CRUD.Data;
using CRUD.Models;
using CRUD.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
	public class EmployeesController : Controller
	{
        public EmployeesController(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public DatabaseContext DatabaseContext { get; }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await DatabaseContext.Employees.ToListAsync();

            return View(employees);
        }

        [HttpGet]
		public IActionResult Add()
		{
			return View();
		}

        [HttpGet]
        public async Task<IActionResult> View(Guid Id) { 
            var employee = DatabaseContext.Employees.FirstOrDefault(x => x.Id == Id);

            if (employee != null)
            {
                var viewModel = new UpdateEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    Salary = employee.Salary,
                    Department = employee.Department,
                    DateOfBirth = employee.DateOfBirth,
                };

                return await Task.Run(() => View(viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth
            };

            await DatabaseContext.Employees.AddAsync(employee);
            await DatabaseContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateEmployeeViewModel updateEmployeeViewModel)
        {
            var employee = await DatabaseContext.Employees.FindAsync(updateEmployeeViewModel.Id);

            if (employee != null)
            {
				employee.Name = updateEmployeeViewModel.Name;
				employee.Email = updateEmployeeViewModel.Email;
				employee.Salary = updateEmployeeViewModel.Salary;
				employee.Department = updateEmployeeViewModel.Department;
				employee.DateOfBirth = updateEmployeeViewModel.DateOfBirth;

				await DatabaseContext.SaveChangesAsync();

				return RedirectToAction("Index");
			}

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel updateEmployeeViewModel)
        {
            var employee = await DatabaseContext.Employees.FindAsync(updateEmployeeViewModel.Id);

            if (employee != null)
            {
                DatabaseContext.Employees.Remove(employee);
                await DatabaseContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
