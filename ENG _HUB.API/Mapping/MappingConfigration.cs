namespace ENG__HUB.API.Mapping
{
    public class MappingConfigration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Course, CourseResponse>()
            .Map(dest => dest.ID, src => src.ID);

           // config.NewConfig<PollRequest, Poll>()
           //.Map(dest => dest.Summary, src => src.Descreption);
        }
    }
}
