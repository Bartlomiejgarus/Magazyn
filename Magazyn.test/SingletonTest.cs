using Warehouse.Forms.Contractor;
using Warehouse.Forms.Incoming;
using Warehouse.Forms.Sale;
using Warehouse.Forms.Towards;
using Warehouse.Forms.Users;
using Xunit;

namespace Warehouse.test
{
    public class SingletonTest
    {
        [Fact]
        public void SingletonOneInstanceTest()
        {
            var instanceSale1 = SaleForm.Instance;
            var instanceSale2 = SaleForm.Instance;
            Assert.Equal(instanceSale1, instanceSale2);

            var instanceIncoming1 = IncomingForm.Instance;
            var instanceIncoming2 = IncomingForm.Instance;
            Assert.Equal(instanceIncoming1, instanceIncoming2);

            var instanceTowards1 = TowardsForm.Instance;
            var instanceTowards2 = TowardsForm.Instance;
            Assert.Equal(instanceTowards1, instanceTowards2);

            var instanceContractor1 = ContractorForm.Instance;
            var instanceContractor2 = ContractorForm.Instance;
            Assert.Equal(instanceContractor1, instanceContractor2);

            var instanceUsers1 = UsersForm.Instance;
            var instanceUsers2 = UsersForm.Instance;
            Assert.Equal(instanceUsers1, instanceUsers2);
        }
        [Fact]
        public void SingletonNoNull()
        {
            Assert.True(SaleForm.IsNull);

            SaleForm instanceSale = SaleForm.Instance;

            Assert.True(!SaleForm.IsNull);


            Assert.True(IncomingForm.IsNull);

            IncomingForm instanceIncoming = IncomingForm.Instance;

            Assert.True(!IncomingForm.IsNull);


            Assert.True(TowardsForm.IsNull);

            TowardsForm instanceTowards = TowardsForm.Instance;

            Assert.True(!TowardsForm.IsNull);


            Assert.True(ContractorForm.IsNull);

            ContractorForm instanceContractor = ContractorForm.Instance;

            Assert.True(!ContractorForm.IsNull);


            Assert.True(UsersForm.IsNull);

            UsersForm instanceUsers = UsersForm.Instance;

            Assert.True(!UsersForm.IsNull);

        }
    }
}