#if NET5_0_OR_GREATER
namespace LiteNetLib
{
    using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;
    using System.Diagnostics.CodeAnalysis;

    internal static class Trimming
    {
        internal const DynamicallyAccessedMemberTypes SerializerMemberTypes = PublicProperties | NonPublicProperties;
    }
}
#endif
