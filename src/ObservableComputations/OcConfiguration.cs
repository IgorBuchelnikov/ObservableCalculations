﻿// Copyright (c) 2019-2021 Buchelnikov Igor Vladimirovich. All rights reserved
// Buchelnikov Igor Vladimirovich licenses this file to you under the MIT license.
// The LICENSE file is located at https://github.com/IgorBuchelnikov/ObservableComputations/blob/master/LICENSE

namespace ObservableComputations
{
	public static class OcConfiguration
	{
		public static bool SaveInstantiationStackTrace = false;
		public static bool SaveOcDispatcherInvocationInstantiationStackTrace = false;
		public static bool SaveOcDispatcherInvocationExecutionStackTrace = false;

		public static bool TrackComputingsExecutingUserCode = false;
		public static int EventUnsubscriberThreadsCount = 1;
	}
}
