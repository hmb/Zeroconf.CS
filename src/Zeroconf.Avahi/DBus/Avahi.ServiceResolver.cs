using System.Runtime.CompilerServices;
using Tmds.DBus;

[assembly: InternalsVisibleTo(Connection.DynamicAssemblyName)]
namespace Zeroconf.Avahi.DBus;

using System;
using System.Threading.Tasks;
using Tmds.DBus;

[DBusInterface("org.freedesktop.Avahi.ServiceResolver")]
interface IServiceResolver : IDBusObject
{
    Task FreeAsync();
    Task<IDisposable> WatchFoundAsync(Action<(int @interface, int protocol, string name, string type, string domain, string host, int aprotocol, string address, ushort port, byte[][] txt, uint flags)> handler, Action<Exception> onError = null);
    Task<IDisposable> WatchFailureAsync(Action<string> handler, Action<Exception> onError = null);
}