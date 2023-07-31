using ProjMgmtDataLibrary.Models;

namespace ProjMgmtDataLibrary.Data
{
    public interface ISqlData
    {
        /* Login */
        EmployeeModel Authenticate(string email, string password);
        void Register(string email, string password, string firstName, string lastName, int roleId, int departmentId, int regionId, string phone, DateTime dateHired);
        /* Role */
        List<ListRoleModel> ListRoles();
        void AddRole(RoleModel role);
        ListRoleModel ShowRoleDetails(int id);
        void EditRole(RoleEdit role, int id);
        void DeleteRole(int id);
        List<ListRoleEmployeesModel> ListRoleEmployees(int id);
        /* Region */
        List<ListRegionModel> ListRegions();
        void AddRegion(RegionModel region);
        ListRegionModel ShowRegionDetails(int id);
        void EditRegion(RegionEdit region, int id);
        void DeleteRegion(int id);
        List<ListRegionEmployeesModel> ListRegionEmployees(int id);
        List<ListRegionClientsModel> ListRegionClients(int id);
        /* Employee */
        List<ListEmployeeModel> ListEmployees();
        ListEmployeeModel ShowEmployeeDetails(int id);
        void EditEmployee(EmployeeEdit employee, int id);
        void DeleteEmployee(int id);
        /* Client */
        List<ListClientModel> ListClients();
        void AddClient(ClientModel client);
        ListClientModel ShowClientDetails(int id);
        void EditClient(ClientEdit client, int id);
        void DeleteClient(int id);
        List<ListClientProjectsModel> ListClientProjects(int id);
        /* Department */
        List<ListDepartmentModel> ListDepartments();
        void AddDepartment(DepartmentModel department);
        ListDepartmentModel ShowDepartmentDetails(int id);
        void EditDepartment(DepartmentEdit department, int id);
        void DeleteDepartment(int id);
        List<ListDepartmentEmployeesModel> ListDepartmentEmployees(int id);
        /* Project */
        List<ListProjectModel> ListProjects();
        void AddProject(ProjectModel project);
        ListProjectModel ShowProjectDetails(int id);
        void EditProject(ProjectEdit project, int id);
        void DeleteProject(int id);
        List<ListProjectTasksModel> ListProjectTasks(int id);
        /* Task */
        List<ListTaskModel> ListTasks();
        void AddTask(TaskModel task, int id);
        ListTaskModel ShowTaskDetails(int id);
        void EditTask(TaskEdit task, int id);
        void DeleteTask(int id);
        List<ListTaskAssignmentsModel> ListTaskAssignments(int id);
        /* Assignment */
        List<ListAssignmentModel> ListAssignments();
        void AddAssignment(AssignmentModel assignment, int id);
        ListAssignmentModel ShowAssignmentDetails(int id);
        void EditAssignment(AssignmentEdit assignment, int id);
        void DeleteAssignment(int id);
        List<ListAssignmentEmployeesModel> ListAssignmentEmployees(int id);
    }
}