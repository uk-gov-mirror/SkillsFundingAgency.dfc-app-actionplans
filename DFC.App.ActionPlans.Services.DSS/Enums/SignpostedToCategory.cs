using System.ComponentModel.DataAnnotations;

namespace DFC.App.ActionPlans.Services.DSS.Enums
{
    public enum SignpostedToCategory
    {
        [Display(Name = "Charity")]
        Charity = 1,

        [Display(Name = "Training Provider")]
        TrainingProvider = 3,

        [Display(Name = "Apprenticeships")]
        ApprenticeshipService = 6,

        [Display(Name = "Specialist Organisation")]
        SpecialistOrganisation = 7,

        JCP = 8,

        Employer = 9,

        [Display(Name = "Traineeships")]
        Traineeships = 10,

        [Display(Name = "Further Education")]
        FurtherEducation = 11,

        [Display(Name = "Higher Education")]
        HigherEducation = 12,

        [Display(Name = "Community Centres")]
        CommunityCentres = 13,
        
        [Display(Name = "Job Centre Plus WITH Data")]
        JCPWithData = 14,
        
        [Display(Name = "Job Centre Plus WITHOUT Data")]
        JCPWithoutData = 15,

        Other = 99
    }
}