using ATMBank;

namespace BankTester
{

    public class UnitTest1
    {
        [Fact]
        public void ReturnViewBalance()
        {
            Program.Balance = 50.0M;

            decimal result = Program.ViewBalance();

            Assert.Equal(50.0M, result);
        }
        [Fact]
        public void ReturnViewBalanceIfBalanceIsEqualToZero()
        {
            Program.Balance = 0;

            decimal result = Program.ViewBalance();

            Assert.Equal(0, result);
        }
        [Fact]

        public void giveTheWithDraw30andReturnTheAmount70()
        {
            //arrange
            Program.Balance = 100.0M;
            decimal Draw = 30.0M;

            //act
            decimal result = Program.WithDraw(Draw);

            // assert   
            Assert.Equal(70.0M, result);

        }
        [Fact]
        public void GiveWithDrawSameValueOfBalance()
        {
            Program.Balance = 50.0M;

            decimal Draw = 50.0M;

            decimal result = Program.WithDraw(Draw);

            Assert.Equal(0, result);

        }
        [Fact]
        public void TestWithDrawIfTheVAlueLessThanZero()
        {
            Program.Balance = 50.0M;

            decimal Draw = -50.0M;

            decimal result = Program.WithDraw(Draw);

            Assert.Equal(-1, result);

        }
        [Fact]

        public void DpositAPostiveAmountToBalance()
        {
            Program.Balance = 20.0M;

            decimal deposite = 30.0M;

            decimal result = Program.Deposit(deposite);

            Assert.Equal(50.0M, result);
        }
        [Fact]

        public void DepositeANeagtiveAmountBalance()
        {
            // Program.Balance = 20.0M;

            decimal deposite = -30.0M;

            decimal result = Program.Deposit(deposite);

            Assert.Equal(-1, result);
        }


    }
}