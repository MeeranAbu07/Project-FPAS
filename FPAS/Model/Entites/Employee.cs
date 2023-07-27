namespace FPAS.Model.Entites
{
    public class Employee
    {
        public long Id { get; set; }
        public int RoleId { get; set; }
        public string FingurePrint { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public int StatusId { get; set; }
    }
}
