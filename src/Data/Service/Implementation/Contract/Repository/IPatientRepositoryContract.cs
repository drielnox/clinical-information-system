﻿using CIS.Data.DataAccess.Repository;
using CIS.Data.Service.Proxy.Repository;
using System.ServiceModel;

namespace CIS.Data.Service.Contract.Repository
{
    [ServiceContract]
    [ServiceKnownType(typeof(PatientRepositoryProxy))]
    public interface IPatientRepositoryContract : IPatientRepository
    {
    }
}
