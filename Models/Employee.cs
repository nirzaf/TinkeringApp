﻿using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Position { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }
    public string? Location { get; set; }
}