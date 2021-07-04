using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class Pttmanager:IDistributor
    {
        private IApplicantService _applicantService;
        public Pttmanager(IApplicantService applicantService)
        {
            _applicantService = applicantService;

        }
        public void GiveHelp(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + "=Helping is gived");
            }
            else
            {
                Console.WriteLine("Helping is not gived!!");
            }
        }
    }
}
