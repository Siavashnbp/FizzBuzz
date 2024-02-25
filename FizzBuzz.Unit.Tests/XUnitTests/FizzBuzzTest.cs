using FizzBuzz.Services;
using FizzBuzz.Services.FizzBuzz.Contracts;
using FizzBuzz.Services.FizzBuzz.Contracts.Exceptions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Unit.Tests.XUnitTests
{
    public class FizzBuzzTest
    {        
        [Fact]
        public void GetIntInput_accepts_valid_int_input()
        {
            string input = "2";
            var expected = 2;
            var _fizzBuzzServices = new FizzBuzzAppServices();
            var actual = _fizzBuzzServices.GetInt(input);

            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(12)]
        [InlineData(15)]
        [InlineData(-15)]
        public void CheckFizz_retruns_true_on_numbers_dividable_by_3(int num)
        {
            var expected = true;
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.CheckFizz(num);

            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(16)]
        [InlineData(-16)]
        public void CheckFizz_returns_false_on_numbers_not_dividable_by_3(int num)
        {
            var expected = false;
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.CheckFizz(num);

            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(-15)]
        public void CheckBuzz_returns_true_on_numbers_dividable_by_5(int num)
        {
            var expected = true;
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.CheckBuzz(num);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(8)]
        [InlineData(28)]
        [InlineData(-28)]
        public void CheckBuzz_returns_false_on_numbers_not_dividable_by_5(int num)
        {
            var expected = false;
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.CheckBuzz(num);

            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData("2.3")]
        [InlineData("saa")]
        [InlineData("22k")]
        public void GetInt_throws_exception_on_invalid_inputs(string input)
        {
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = () => _fizzBuzzServices.GetInt(input);

            actual.Should().ThrowExactly<InvalidIntInputException>();
        }
        [Fact]
        public void PrintResult_should_return_FizzBuzz_on_fizz_and_buzz_numbers_()
        {
            var isFizz = true;
            var isBuzz = true;
            var expected = "FizzBuzz";
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.PrintResult(isFizz, isBuzz);

            actual.Should().Be(expected);
        }
        [Fact]
        public void PrintResult_should_return_Fizz_on_fizz_only_numbers_()
        {
            var isFizz = true;
            var isBuzz = false;
            var expected = "Fizz";
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.PrintResult(isFizz, isBuzz);

            actual.Should().Be(expected);
        }
        [Fact]
        public void PrintResult_should_return_Buzz_on_buzz_only_numbers_()
        {
            var isFizz = false;
            var isBuzz = true;
            var expected = "Buzz";
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.PrintResult(isFizz, isBuzz);

            actual.Should().Be(expected);
        }
        [Fact]
        public void PrintResult_should_return_empty_string_on_neither_fizz_nor_buzz__numbers_()
        {
            var isFizz = false;
            var isBuzz = false;
            var expected = string.Empty;
            var _fizzBuzzServices = new FizzBuzzAppServices();

            var actual = _fizzBuzzServices.PrintResult(isFizz, isBuzz);

            actual.Should().Be(expected);
        }
    }
}
