using System;
using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	/// <summary>
	/// Metadata about a Snapshot lifecycle policy
	/// </summary>
	public class SnapshotLifecyclePolicyMetadata
	{
		/// <summary>
		/// The modified date.
		/// Returned only when Human is set to <c>true</c> on the request
		/// </summary>
		[DataMember(Name = "modified_date")]
		public DateTimeOffset? ModifiedDate { get; internal set; }

		/// <summary>
		/// The modified date in milliseconds
		/// </summary>
		[DataMember(Name = "modified_date_millis")]
		public long ModifiedDateInMilliseconds { get; internal set; }

		/// <summary>
		/// The next execution date.
		/// Returned only when Human is set to <c>true</c> on the request
		/// </summary>
		[DataMember(Name = "next_execution")]
		public DateTimeOffset? NextExecution { get; internal set; }

		/// <summary>
		/// The next execution date in milliseconds
		/// </summary>
		[DataMember(Name = "next_execution_millis")]
		public long NextExecutionInMilliseconds { get; internal set; }

		/// <summary>
		/// The snapshot lifecycle policy
		/// </summary>
		[DataMember(Name = "policy")]
		public SnapshotLifecyclePolicy Policy { get; internal set; }

		/// <summary>
		/// The version
		/// </summary>
		[DataMember(Name = "version")]
		public int Version { get; internal set; }

		/// <summary>
		/// If a snapshot is currently in progress this will return information about the snapshot.
		/// </summary>
		[DataMember(Name = "in_progress")]
		public LifecycleSnapshotInProgress InProgress { get; internal set; }
	}

	/// <summary>
	/// If a snapshot is in progress when calling the Get Snapshot Lifecycle metadata
	/// this will hold some minimal information about the in flight snapshot
	/// </summary>
	public class LifecycleSnapshotInProgress
	{
		/// <summary> The name of the snapshot currently being taken </summary>
		[DataMember(Name = "name")]
		public string Name { get; internal set; }

		/// <summary> The UUI of the snapshot currently being taken </summary>
		[DataMember(Name = "uuid")]
		public string UUID { get; internal set; }

		/// <summary> The state of the snapshot currently being taken </summary>
		[DataMember(Name = "state")]
		public string State { get; internal set; }

		/// <summary> The start time of the snapshot currently being taken </summary>
		[DataMember(Name = "start_time_millis")]
		[JsonFormatter(typeof(DateTimeOffsetEpochMillisecondsFormatter))]
		public DateTimeOffset StartTime { get; internal set; }

	}
}
