using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICostumerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICostumerDal
    {
        public void Add() 
        {
            Console.WriteLine("Sql Added");
        }
        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
        public void Delete() 
        {
            Console.WriteLine("Sql Deleted");
        }

    }

    class OracleCustomerDal : ICostumerDal
    {
        public void Add() 
        {
            Console.WriteLine("Oracle Added");
        }
        public void Update() 
        {
            Console.WriteLine("Oracle Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class MySqlCustomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }
        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICostumerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
