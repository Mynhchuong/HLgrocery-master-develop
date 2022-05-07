using HLgrocery.Data.Infrastructure;
using HLgrocery.Data.Reposittories;
using HLgrocery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLgrocery.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Udate(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllpaging(int page , int pageSize , out int totalrow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllTagpaging(string tag , int page, int pageSize, out int totalrow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository , IUnitOfWork unitofwork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitofwork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
          return  _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllpaging(int page, int pageSize, out int totalrow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalrow, page, pageSize);
        }
        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }
        public IEnumerable<Post> GetAllTagpaging(string tag, int page, int pageSize, out int totalrow)
        {
            
            return _postRepository.GetAllByTag(tag , page , pageSize, out totalrow);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Udate(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
