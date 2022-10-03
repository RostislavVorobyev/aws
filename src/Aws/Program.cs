using Amazon.CDK;

namespace Aws
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new WorkshopPipelineStack(app, "WorkshopPipelineStack");
            app.Synth();
        }
    }
}
