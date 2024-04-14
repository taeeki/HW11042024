using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treatment;

namespace Patients
{
    internal class Patient
    {
        TreatmentPlan treatment;
        public Patient(TreatmentPlan treatment) 
        {
            this.treatment = treatment;
        }

        public void AssigntDoctor()
        {
            Doctor doctor;
            switch (treatment.Code)
            {
                case 1: 
                    doctor = new Surgeon(); 
                    break;
                case 2: 
                    doctor = new Dentist();
                    break;

                default:
                    doctor = new Therapist();
                    break;
            }
            TreatDoctor(doctor);
        }

        private void TreatDoctor(Doctor doctor)
        {
            doctor.Treat();
        }
    }
}
