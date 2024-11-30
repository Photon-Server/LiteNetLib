#if NET5_0_OR_GREATER
using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

namespace LiteNetLib
{
    using System.Diagnostics.CodeAnalysis;

    internal static class Trimming
    {
        internal const DynamicallyAccessedMemberTypes SerializerMemberTypes = PublicProperties | NonPublicProperties;
    }
}
#endif
