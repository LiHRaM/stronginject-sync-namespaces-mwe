using StrongInject;

using stronginject_sync_namespaces_mwe.Interfaces;

namespace stronginject_sync_namespaces_mwe;

[Register(typeof(Demo), typeof(IDemo))]
public partial class Container : IContainer<IDemo>
{
}
