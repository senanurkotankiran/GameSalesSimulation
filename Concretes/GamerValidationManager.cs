using GameDemo.Abstracts;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameDemo
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalityId,gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.Year.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;

        }
    }

}

