using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using azureDevOpsTestLiab;
using Machine.Specifications;

namespace azureDevOpsTest
{
   public class When_test_machine_spec_tests
    {
        static AzureService Subject;
        static bool Result;

        Establish context = () =>
            Subject = new AzureService();

        Because of = () =>
            Result = Subject.Sleep100ThenReturnTrue();

        It should_indicate_the_users_role = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role1 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role2 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role3 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role4 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role5 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role6 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role7 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role8 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role9 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role0 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role11 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role12 = () =>
            Result.ShouldEqual(true);
        It should_indicate_the_users_role13 = () =>
            Result.ShouldEqual(true);
    }
}
