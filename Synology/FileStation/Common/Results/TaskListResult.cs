﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskListResult
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public abstract class TaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : TaskListResult
        where TFileListResult : TaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileAdditionalResult : TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
        where TFileResult : TaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult>, new()
    {
        [JsonProperty("files")]
        public IEnumerable<TFileResult> Files { get; set; }
    }

    public abstract class TaskShareListResult<TShareAdditionalResult, TShareResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : TaskListResult
        where TShareResult : TaskShareResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>, new()
        where TShareAdditionalResult : TaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>, new()
        where TShareOwnerResult : TaskShareOwnerResult, new()
        where TShareTimeResult : TaskShareTimeResult, new()
        where TSharePermResult : TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>, new()
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TShareVolumeStatusResult : TaskShareVolumeStatusResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        [JsonProperty("shares")]
        public IEnumerable<TShareResult> Shares { get; set; }
    }

    public abstract class TaskVirtualFolderListResult<TVirtualFolderResult, TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : TaskListResult
        where TVirtualFolderResult : TaskVirtualFolderResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>, new()
        where TVirtualFolderAdditionalResult : TaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>, new()
        where TVirtualFolderOwnerResult : TaskVirtualFolderOwnerResult, new()
        where TVirtualFolderTimeResult : TaskVirtualFolderTimeResult, new()
        where TVirtualFolderPermResult : TaskVirtualFolderPermResult<TVirtualFolderPermAclResult>, new()
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
        where TVirtualFolderVolumeStatusResult : TaskVirtualFolderVolumeStatusResult, new()
    {
        [JsonProperty("folders")]
        public IEnumerable<TVirtualFolderResult> Folders { get; set; }
    }
}
