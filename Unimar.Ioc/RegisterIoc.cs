using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Unimar.Dominio.Interfaces;
using Unimar.Dominio.Repositorio;
using Unimar.Dominio.Servicos;
using Unimar.Infra.FireBase;
using Unimar.Infra.FireBase.Repositorio;

namespace Unimar.Ioc
{
    public static class RegisterIoc
    {
        public static IServiceCollection AddIoC(this IServiceCollection services, IConfiguration cfg)
        {
            services.AddTransient<IRepositorioProfessor, ProfessorRepositorio>();
            services.AddTransient<IProfessorServico, ProfessorServico>();

            var firebaseOptions = new FireBaseOptions
            {
                ApiKey = cfg["Firebase:ApiKey"] ?? string.Empty,
                ProjectId = cfg["Firebase:ProjectId"] ?? string.Empty,
                ServiceAccountPath = cfg["Firebase:ServiceAccountPath"] ?? string.Empty
            };

            services.AddSingleton(provider =>
            {
                var googleCredential =
                    CredentialFactory
                        .FromFile<ServiceAccountCredential>(firebaseOptions.ServiceAccountPath)
                        .ToGoogleCredential();

                var db = new FirestoreDbBuilder
                {
                    ProjectId = firebaseOptions.ProjectId,
                    Credential = googleCredential
                }.Build();

                return db;
            });


            return services;
        }
    }
}
