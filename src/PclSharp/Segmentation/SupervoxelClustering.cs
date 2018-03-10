﻿// Code generated by a template
using PclSharp.Common;
using PclSharp.Search;
using PclSharp.Std;

namespace PclSharp.Segmentation
{
	public abstract class SupervoxelClustering<PointT> : UnmanagedObject
	{
		public abstract void SetInputCloud(PointCloud<PointT> cloud);
		public abstract void Extract(SupervoxelClusters<PointT> clusters);
	}
}