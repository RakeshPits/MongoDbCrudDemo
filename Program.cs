using System;
using System.Dynamic;

namespace MongoDbConsolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerCrud = new MongoCrud<CustomerModel>(new CustomerDatabaseSettings());

            #region Create
            //var customer = new CustomerModel { FirstName = "Customer1FirstName", LastName = "Customer1LasttName",
            //                PermenantAddress = new AddressModel { HouseNumber = "1", HouseName = "Name1", Street ="Street1",
            //                                                      City = "City1", State ="State1", Nation = "Nation1", PinCode = "Pincode1"}
            //};

            //customerCrud.Insert(customer);
            #endregion

            #region Read All
            var customers = customerCrud.Select();
            #endregion

            #region Read By Id
            //var customer = customerCrud.SelectById(new Guid("19c5c743-6a53-45ad-b614-37f77951a400"));
            //customer.FirstName = "FirstName2";
            //customer.CurrentAddress = new AddressModel{HouseNumber = "1",HouseName = "Name1",Street = "Street1",
            //                                            City = "City1", State ="State1", Nation = "Nation1", PinCode = "Pincode1"};
            #endregion

            #region Update
            //customerCrud.Update(customer.Id, customer);
            #endregion

            #region Delete
            customerCrud.Delete(new Guid("19c5c743-6a53-45ad-b614-37f77951a400"));
            #endregion

        }
    }
}
