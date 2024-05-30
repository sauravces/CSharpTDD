using Calculator;

namespace SimpleTDDCsharpTest
{
	public class Date_Object_Test
	{
        private readonly Date_Object _date_Object;
        private readonly Mock<IDNS> _dNS;
        public Date_Object_Test()
        {
            _dNS =new Mock<IDNS>();
            _date_Object =new  Date_Object(_dNS.Object);
        }

        [Fact]
        public void Test_DNSService_Mocking_With_SendDNS()
        {
            //Arrange
            _dNS.Setup(Service=>Service.SendDNS()).Returns(true);
            //Act
            var result=_date_Object.SendDNSStatus();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Fact]
		public void Test_Date_Should_Before_And_After()
		{
			//Arrange
			//Act
			var result= _date_Object.GetDate();
			//Assert
			result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
		}

		[Fact]
		public void Test_Object_Should_Expected_Object()
		{
			//Arrange
			var expected = new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			};
			//Act
			var result= _date_Object.GetObject();
            //Assert
            result.Should().BeOfType<PingOptions>();
			result.Should().BeEquivalentTo(expected);
			result.Ttl.Should().Be(expected.Ttl);
		}

        [Fact]
        public void Test_RecentPings_ReturnObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            var expectedResult = new PingOptions()
            {
                DontFragment = false,
                Ttl = 3
            };
            //Act
            var result = _date_Object.GetRecentPings();
            //Assert
            result.Should().ContainEquivalentOf(expected);
            result.Should().ContainEquivalentOf(expectedResult);
            result.Should().Contain(x=>x.DontFragment==true);
        }

        [Fact]
        public void Test_String_Result()
        {
            //Arrange
            string name = "Saurav";
            //Act
            var result = _date_Object.GetString();
            //Assert
            result.Should().Be(name);
            result.Should().Be("Saurav");
            result.Should().Contain("Sa");
            result.Should().NotBeNull();
            result.Should().NotBeNullOrWhiteSpace();
        }
    }
}