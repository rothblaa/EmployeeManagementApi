﻿namespace EmployeeManagement.Models
{
    public class Employee
    {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Position { get; set; }
    }
}
