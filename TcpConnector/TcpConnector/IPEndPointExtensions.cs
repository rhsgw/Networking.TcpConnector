using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Networking
{
	/// <summary>
	/// 
	/// </summary>
	public static class IPEndPointExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="local"></param>
		/// <param name="remote"></param>
		/// <returns></returns>
		public static TcpConnector CreateConnectorTo(this IPEndPoint local, IPEndPoint remote) =>
			new TcpConnector(local, remote);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="local"></param>
		/// <param name="remote"></param>
		/// <param name="secondsToKeepAlive"></param>
		/// <param name="keepAliveRetryCount"></param>
		/// <param name="secondsToRetry"></param>
		/// <returns></returns>
		public static TcpConnector CreateConnectorTo(this IPEndPoint local, IPEndPoint remote, int secondsToKeepAlive, int keepAliveRetryCount, int secondsToRetry) =>
			new TcpConnector(local, remote, secondsToKeepAlive, keepAliveRetryCount, secondsToRetry);
	}
}
