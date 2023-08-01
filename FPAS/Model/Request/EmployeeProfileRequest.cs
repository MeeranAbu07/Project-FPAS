namespace FPAS.Model.Request
{
    public class EmployeeProfileRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationalatiy { get; set; }
        public string State { get; set; }
        public string Distict { get; set; }
        public string Address { get; set; }
        public DateTime DateOfJoinig { get; set; }
    }
}
