using Xunit;
using System;
using System.Collections.Generic;
using TEMPLATE.Objects; // not always necesssry
using System.Data;
using System.Data.SqlClient;

namespace  TEMPLATE
{
  public class TEMPLATETest : IDisposable
  {
    public TEMPLATETest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void TEMPLATE_true()
    {
      //Arrange
      //Act
      //Assert
      Assert.Equal(true/false, TEMPLATE);
    }

    public void Dispose()
    {
      TEMPLATE_OBJECT.DeleteAll(); //TEMPLATE_OBJECT references the object name
    }

  }
}
