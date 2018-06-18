using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlashCard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gourmet_s_Choice;

namespace FlashCard.Data.Tests
{
    [TestClass()]
    public class EntityDataTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Food food = new Food();
            food.FoodName = "date";

            DataRepository.Food.Insert(food);
            Assert.Fail();
        }
    }
}