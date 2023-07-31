using ProjMgmtDataLibrary.Database;
using ProjMgmtDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtDataLibrary.Data
{
    public class SqlData : ISqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDB";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public EmployeeModel Authenticate(string email, string password)
        {
            EmployeeModel result = _db.LoadData<EmployeeModel, dynamic>("dbo.spEmployees_Authenticate",
                                                                    new { email, password },
                                                                    connectionStringName,
                                                                    true).FirstOrDefault();
            return result;
        }

        public void Register(string email, string password, string firstName, string lastName, int roleId, int departmentId, int regionId, string phone, DateTime dateHired)
        {
            _db.SaveData<EmployeeModel, dynamic>("dbo.spEmployees_Register",
                new { email, password, firstName, lastName, roleId, departmentId, regionId, phone, dateHired  },
                connectionStringName,
                true);
        }

        /* Role */

        public List<ListRoleModel> ListRoles()
        {
            return _db.LoadData<ListRoleModel, dynamic>("dbo.spRoles_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddRole(RoleModel role)
        {
            _db.SaveData<RoleModel, dynamic>("spRoles_Add",
                new { role.Role },
                connectionStringName,
                true);
        }

        public ListRoleModel ShowRoleDetails(int id)
        {
            return _db.LoadData<ListRoleModel, dynamic>("dbo.spRoles_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditRole(RoleEdit role, int id)
        {
            _db.SaveData<RoleEdit, dynamic>("spRoles_Edit",
                new { id, role.Role },
                connectionStringName,
                true);
        }

        public void DeleteRole(int id)
        {
            _db.SaveData<RoleModel, dynamic>("spRoles_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListRoleEmployeesModel> ListRoleEmployees(int id)
        {
            return _db.LoadData<ListRoleEmployeesModel, dynamic>("dbo.spRoleEmployees_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Region */

        public List<ListRegionModel> ListRegions()
        {
            return _db.LoadData<ListRegionModel, dynamic>("dbo.spRegions_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddRegion(RegionModel region)
        {
            _db.SaveData<RegionModel, dynamic>("spRegions_Add",
                new { region.Region, region.Code },
                connectionStringName,
                true);
        }

        public ListRegionModel ShowRegionDetails(int id)
        {
            return _db.LoadData<ListRegionModel, dynamic>("dbo.spRegions_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditRegion(RegionEdit region, int id)
        {
            _db.SaveData<RegionEdit, dynamic>("spRegions_Edit",
                new { id, region.Region, region.Code },
                connectionStringName,
                true);
        }

        public void DeleteRegion(int id)
        {
            _db.SaveData<RegionModel, dynamic>("spRegions_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListRegionEmployeesModel> ListRegionEmployees(int id)
        {
            return _db.LoadData<ListRegionEmployeesModel, dynamic>("dbo.spRegionEmployees_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        public List<ListRegionClientsModel> ListRegionClients(int id)
        {
            return _db.LoadData<ListRegionClientsModel, dynamic>("dbo.spRegionClients_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Employee */

        public List<ListEmployeeModel> ListEmployees()
        {
            return _db.LoadData<ListEmployeeModel, dynamic>("dbo.spEmployees_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public ListEmployeeModel ShowEmployeeDetails(int id)
        {
            return _db.LoadData<ListEmployeeModel, dynamic>("dbo.spEmployees_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditEmployee(EmployeeEdit employee, int id)
        {
            _db.SaveData<EmployeeEdit, dynamic>("spEmployees_Edit",
                new { id, employee.Password, employee.Phone  },
                connectionStringName,
                true);
        }

        public void DeleteEmployee(int id)
        {
            _db.SaveData<EmployeeModel, dynamic>("spEmployees_Delete",
                new { id },
                connectionStringName,
                true);
        }

        /* Client */

        public List<ListClientModel> ListClients()
        {
            return _db.LoadData<ListClientModel, dynamic>("dbo.spClients_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddClient(ClientModel client)
        {
            _db.SaveData<ClientModel, dynamic>("spClients_Add",
                new { client.Name, client.Phone, client.Email, client.RegionId },
                connectionStringName,
                true);
        }

        public ListClientModel ShowClientDetails(int id)
        {
            return _db.LoadData<ListClientModel, dynamic>("dbo.spClients_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditClient(ClientEdit client, int id)
        {
            _db.SaveData<ClientEdit, dynamic>("spClients_Edit",
                new { id, client.Phone, client.Email },
                connectionStringName,
                true);
        }

        public void DeleteClient(int id)
        {
            _db.SaveData<ClientModel, dynamic>("spClients_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListClientProjectsModel> ListClientProjects(int id)
        {
            return _db.LoadData<ListClientProjectsModel, dynamic>("dbo.spClientProjects_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Department */

        public List<ListDepartmentModel> ListDepartments()
        {
            return _db.LoadData<ListDepartmentModel, dynamic>("dbo.spDepartments_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddDepartment(DepartmentModel department)
        {
            _db.SaveData<DepartmentModel, dynamic>("spDepartments_Add",
                new { department.Department, department.Description },
                connectionStringName,
                true);
        }

        public ListDepartmentModel ShowDepartmentDetails(int id)
        {
            return _db.LoadData<ListDepartmentModel, dynamic>("dbo.spDepartments_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditDepartment(DepartmentEdit department, int id)
        {
            _db.SaveData<DepartmentEdit, dynamic>("spDepartments_Edit",
                new { id, department.Department, department.Description },
                connectionStringName,
                true);
        }

        public void DeleteDepartment(int id)
        {
            _db.SaveData<DepartmentModel, dynamic>("spDepartments_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListDepartmentEmployeesModel> ListDepartmentEmployees(int id)
        {
            return _db.LoadData<ListDepartmentEmployeesModel, dynamic>("dbo.spDepartmentEmployees_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Project */

        public List<ListProjectModel> ListProjects()
        {
            return _db.LoadData<ListProjectModel, dynamic>("dbo.spProjects_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddProject(ProjectModel project)
        {
            _db.SaveData<ProjectModel, dynamic>("spProjects_Add",
                new { project.Title, project.Description, project.ClientId, project.Budget, project.EmployeeId, project.StartDate, project.EndDate },
                connectionStringName,
                true);
        }

        public ListProjectModel ShowProjectDetails(int id)
        {
            return _db.LoadData<ListProjectModel, dynamic>("dbo.spProjects_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditProject(ProjectEdit project, int id)
        {
            _db.SaveData<ProjectEdit, dynamic>("spProjects_Edit",
                new { id, project.Title, project.Description, project.Budget },
                connectionStringName,
                true);
        }

        public void DeleteProject(int id)
        {
            _db.SaveData<ProjectModel, dynamic>("spProjects_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListProjectTasksModel> ListProjectTasks(int id)
        {
            return _db.LoadData<ListProjectTasksModel, dynamic>("dbo.spProjectTasks_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Task */

        public List<ListTaskModel> ListTasks()
        {
            return _db.LoadData<ListTaskModel, dynamic>("dbo.spTasks_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddTask(TaskModel task, int id)
        {
            _db.SaveData<TaskModel, dynamic>("spTasks_Add",
                new { id, task.Description, task.ProjectId, task.BeginDate, task.DueDate },
                connectionStringName,
                true);
        }

        public ListTaskModel ShowTaskDetails(int id)
        {
            return _db.LoadData<ListTaskModel, dynamic>("dbo.spTasks_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditTask(TaskEdit task, int id)
        {
            _db.SaveData<TaskEdit, dynamic>("spTasks_Edit",
                new { id, task.Description },
                connectionStringName,
                true);
        }

        public void DeleteTask(int id)
        {
            _db.SaveData<TaskModel, dynamic>("spTasks_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListTaskAssignmentsModel> ListTaskAssignments(int id)
        {
            return _db.LoadData<ListTaskAssignmentsModel, dynamic>("dbo.spTaskTasks_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

        /* Assignment */

        public List<ListAssignmentModel> ListAssignments()
        {
            return _db.LoadData<ListAssignmentModel, dynamic>("dbo.spAssignments_List",
                new { },
                connectionStringName,
                true).ToList();
        }

        public void AddAssignment(AssignmentModel assignment, int id)
        {
            _db.SaveData<AssignmentModel, dynamic>("spAssignments_Add",
                new { id, assignment.TaskId, assignment.DepartmentId, assignment.EmployeeId, assignment.StartDate, assignment.EndDate },
                connectionStringName,
                true);
        }

        public ListAssignmentModel ShowAssignmentDetails(int id)
        {
            return _db.LoadData<ListAssignmentModel, dynamic>("dbo.spAssignments_Details",
                new { id },
                connectionStringName,
                true).FirstOrDefault();
        }

        public void EditAssignment(AssignmentEdit assignment, int id)
        {
            _db.SaveData<AssignmentEdit, dynamic>("spAssignments_Edit",
                new { id, assignment.EmployeeId, assignment.StartDate, assignment.EndDate },
                connectionStringName,
                true);
        }

        public void DeleteAssignment(int id)
        {
            _db.SaveData<AssignmentModel, dynamic>("spAssignments_Delete",
                new { id },
                connectionStringName,
                true);
        }

        public List<ListAssignmentEmployeesModel> ListAssignmentEmployees(int id)
        {
            return _db.LoadData<ListAssignmentEmployeesModel, dynamic>("dbo.spAssignmentEmployees_List",
                new { id },
                connectionStringName,
                true).ToList();
        }

    }
}
