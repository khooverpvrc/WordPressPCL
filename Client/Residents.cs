using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace WordPressPCL.Client
{ 
/// <summary>
/// Summary description for Class1
/// </summary>
public class Residents : CRUDOperation<Resident, ResidentsQueryBuilder>
{

        #region Init

    private new const string _methodPath = "residents";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="HttpHelper">reference to HttpHelper class for interaction with HTTP</param>
    /// <param name="defaultPath">path to site, EX. http://demo.com/wp-json/ </param>
    public Residents(ref HttpHelper HttpHelper, string defaultPath) : base(ref HttpHelper, defaultPath, _methodPath)
        {
    }

    #endregion Init

    #region Custom

    /// <summary>
    /// Get sticky Residents
    /// </summary>
    /// <param name="embed">includ embed info</param>
    /// <param name="useAuth">Send request with authenication header</param>
    /// <returns>List of Residents</returns>
    public Task<IEnumerable<Post>> GetStickyResidents(bool embed = false, bool useAuth = false)
    {
        // default values
        // int page = 1, int per_page = 10, int offset = 0, Post.OrderBy orderby = Post.OrderBy.date
        return _httpHelper.GetRequest<IEnumerable<Post>>($"{_defaultPath}{_methodPath}?sticky=true", embed, useAuth);
    }

    /// <summary>
    /// Get Residents by category
    /// </summary>
    /// <param name="categoryId">Category Id</param>
    /// <param name="embed">includ embed info</param>
    /// <param name="useAuth">Send request with authenication header</param>
    /// <returns>List of Residents</returns>
    public Task<IEnumerable<Post>> GetResidentsByCategory(int categoryId, bool embed = false, bool useAuth = false)
    {
        // default values
        // int page = 1, int per_page = 10, int offset = 0, Post.OrderBy orderby = Post.OrderBy.date
        return _httpHelper.GetRequest<IEnumerable<Post>>($"{_defaultPath}{_methodPath}?categories={categoryId}", embed, useAuth);
    }

    /// <summary>
    /// Get Residents by tag
    /// </summary>
    /// <param name="tagId">Tag Id</param>
    /// <param name="embed">includ embed info</param>
    /// <param name="useAuth">Send request with authenication header</param>
    /// <returns>List of Residents</returns>
    public Task<IEnumerable<Post>> GetResidentsByTag(int tagId, bool embed = false, bool useAuth = false)
    {
        // default values
        // int page = 1, int per_page = 10, int offset = 0, Post.OrderBy orderby = Post.OrderBy.date
        return _httpHelper.GetRequest<IEnumerable<Post>>($"{_defaultPath}{_methodPath}?tags={tagId}", embed, useAuth);
    }

    /// <summary>
    /// Get Residents by its author
    /// </summary>
    /// <param name="authorId">Author id</param>
    /// <param name="embed">includ embed info</param>
    /// <param name="useAuth">Send request with authenication header</param>
    /// <returns>List of Residents</returns>
    public Task<IEnumerable<Post>> GetResidentsByAuthor(int authorId, bool embed = false, bool useAuth = false)
    {
        // default values
        // int page = 1, int per_page = 10, int offset = 0, Post.OrderBy orderby = Post.OrderBy.date
        return _httpHelper.GetRequest<IEnumerable<Post>>($"{_defaultPath}{_methodPath}?author={authorId}", embed, useAuth);
    }

    /// <summary>
    /// Get Residents by search term
    /// </summary>
    /// <param name="searchTerm">Search term</param>
    /// <param name="embed">include embed info</param>
    /// <param name="useAuth">Send request with authenication header</param>
    /// <returns>List of Residents</returns>
    public Task<IEnumerable<Post>> GetResidentsBySearch(string searchTerm, bool embed = false, bool useAuth = false)
    {
        // default values
        // int page = 1, int per_page = 10, int offset = 0, Post.OrderBy orderby = Post.OrderBy.date
        return _httpHelper.GetRequest<IEnumerable<Post>>($"{_defaultPath}{_methodPath}?search={searchTerm}", embed, useAuth);
    }

    /// <summary>
    /// Delete post with force deletion
    /// </summary>
    /// <param name="ID">Post id</param>
    /// <param name="force">force deletion</param>
    /// <returns>Result of opertion</returns>
    public Task<HttpResponseMessage> Delete(int ID, bool force = false)
    {
        return _httpHelper.DeleteRequest($"{_defaultPath}{_methodPath}/{ID}?force={force.ToString().ToLower()}");
    }

    /// <summary>
    /// Get instance ob object to manipulate with post revisions
    /// </summary>
    /// <param name="postId">ID of parent Post</param>
    /// <returns>Post revisions object</returns>
    public PostRevisions Revisions(int postId)
    {
        return new PostRevisions(ref _httpHelper, _defaultPath, postId);
    }

    #endregion Custom
}
}

