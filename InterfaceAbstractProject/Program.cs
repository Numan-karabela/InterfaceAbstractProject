
using InterfaceAbstractProject.Abstract;
using InterfaceAbstractProject.Concrete;

BaseCustomerManager customerManager = new DoraCustomerManager();

customerManager.save(new Customer
{
    Id = 1,
    DateTime = DateTime.Now,
    FirsName="Numan",
    LastName="Karabela",
    NationalityId="256399895"

});


