namespace WisdomPetMedicine.PetAggregator.Api.Models;
public record PetModel(Guid Id, string Name, string Breed, string Sex, string Color, DateTime DateOfBirth, string Species);
public record RescueModel(Guid Id, Guid? AdopterId, string AdopterName, string AdoptionStatus);
public record PatientModel(Guid Id, string BloodType, decimal? Weight, string Status);