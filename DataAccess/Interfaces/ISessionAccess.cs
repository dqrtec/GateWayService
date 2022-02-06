using System;

namespace DataAccess.Interfaces{
    interface ISessionAccess{
        void CreateSession();
        string GetSession();
    }
}