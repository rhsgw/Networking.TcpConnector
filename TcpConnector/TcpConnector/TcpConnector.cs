using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking
{
	/// <summary>
	/// 
	/// </summary>
	public class TcpConnector:IDisposable, INotifyPropertyChanged
	{
		internal TcpConnector(IPEndPoint local, IPEndPoint remote) { }
		internal TcpConnector(IPEndPoint local, IPEndPoint remote, int secondsToKeepAlive, int keepAliveRetryCount, int secondsToRetry) { }

		/// <summary>
		/// リモートホストとの接続が確立されているときは true
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// NetworkStream から読み取り可能なデータを非同期に読み取る
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public ValueTask<byte[]> ReadAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

		/// <summary>
		/// NetworkStream へデータを非同期に書き込む
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) => throw new NotImplementedException();

		/// <summary>
		/// 
		/// </summary>
		public void Dispose() => throw new NotImplementedException();

		/// <summary>
		/// 
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
