

namespace ENG__HUB.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddDepnendacies(this IServiceCollection services,
             IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDataBaseConfig(configuration); //Add DbContext to DI container



            services.AddSwagger()           //configuring Swagger/OpenAPI 
                .AddFluentValidation()      //Add  Fluent Validation
                .AddMappster();             //Add Mappster


            // Add Generic Service to DI
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));


            return services;
        }
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;

        }
        public static IServiceCollection AddMappster(this IServiceCollection services)
        {

            var MappingConfig = TypeAdapterConfig.GlobalSettings;
            MappingConfig.Scan(Assembly.GetExecutingAssembly());
            services.AddSingleton<IMapper>(new Mapper(MappingConfig));

            return services;

        }
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {

            services
               .AddFluentValidationAutoValidation()
               .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;

        }
        public static IServiceCollection AddDataBaseConfig(this IServiceCollection services,
            IConfiguration configuration)
        {
            

            var contectionString = configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException("DefaultConnection is not found");

            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(contectionString));

            return services;

        }
    }
}
