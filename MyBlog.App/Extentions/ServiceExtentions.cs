﻿using MyBlog.Data.Repositories.Interfaces;
using MyBlog.Data.Repositories;
using MyBlog.BLL.Services.Interfaces;
using MyBlog.BLL.Services;
using AutoMapper;
using MyBlog.Data.Models.Articles;
using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Tags;
using MyBlog.Data.Models.Users;

namespace MyBlog.App.Extentions
{
    /// <summary>
    /// Методы расширения сервисов
    /// </summary>
    public static class ServiceExtentions
    {
        #region Реализация паттерна UnitOfWork
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddCustomRepository<TEntity, IRepository>(this IServiceCollection services)
                 where TEntity : class
                 where IRepository : class, IRepository<TEntity>
        {
            services.AddScoped<IRepository<TEntity>, IRepository>();

            return services;
        }
        #endregion

        #region Реализация IoC для сервисов
        public static IServiceCollection AddServicesBL(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IDataDefaultService, DataDefaultService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
		#endregion

		#region Реализация IoC для репозиториев
		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddSingleton<IRepository<Article>, ArticleRepository>();
			services.AddSingleton<IRepository<Comment>, CommentRepository>();
			services.AddSingleton<IRepository<Tag>, TagRepository>();
			services.AddSingleton<IRepository<User>, UserRepository>();

			return services;
		}
		#endregion


        #region Конфигурация automapper'a
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration((v) =>
            {
                v.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
        #endregion
    }
}
