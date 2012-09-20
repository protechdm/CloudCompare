using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudCompare.Domain.Models;

namespace CloudCompare.Domain.Contracts.Repositories
{
    public interface ICloudCompareRepository : IBaseRepository
    {
        IList<SearchFilterTwoColumn> Test();
        IList<Category> GetCategories();
        IList<Domain.Models.OperatingSystem> GetOperatingSystems();
        IList<SearchResult> GetFeaturedCloudware();
        IList<SearchResult> GetTopTenCloudware();
        IList<SearchResult> GetNewCloudware();
        IList<SearchFilterTwoColumn> GetSearchOptions(int categoryID);
        IList<CloudApplication> GetSearchResults(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate);
        //bool InsertCase(string userId, string hostAddress, string hostName, string insertAction, Case model);
        //QueueAndUserID GetQueueAndUserIDBasedOnRA(Case inputCase, string country, string invoiceNumber);
        //IList<User> GetUsers(string EMailAddress, string passWord);
        //IList<User> GetUsers(string EMailAddress);
        //IList<User> GetUsers();
        //bool InsertUser(User model);
        //IList<Case> GetCases();
        //IList<Case> GetCases(string user);
        //Case GetCase(string caseNumber);

    }
}
