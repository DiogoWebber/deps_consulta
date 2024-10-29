namespace Deps_Consulta.SharedKernel.Util
{
    public static class AmbienteUtil
    {
        public static string GetValue(string variableName)
        {
            return Environment.GetEnvironmentVariable(variableName);
        }
    }
}