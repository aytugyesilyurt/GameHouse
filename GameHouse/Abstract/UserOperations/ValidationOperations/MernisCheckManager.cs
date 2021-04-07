using GameHouse.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Abstract.UserOperations.ValidationOperations
{
    // Mernis bir kimlik doğrulama çeşidi. Farklı kimlik doğrulama çeşitleri de olabilir.
    public class MernisCheckManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(user.NationalNumber), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.BirthYear.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
