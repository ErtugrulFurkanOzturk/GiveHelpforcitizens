using Business.Abstract;
using Entities.Concrete;
using MerServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForHelp(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.Nationalidentity,Ad:person.Firstname,Soyad:person.Lastname,DogumYili:person.Dateofbirthyear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
