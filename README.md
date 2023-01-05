# ARMarkPositon
<!-- img src="DocGen/Images/WorldLockingSamples.svg" -->

The aim of this project is to implement an AR application so that the user can mark the space either as digging of dumping on the construction site.
And the output is a csv file which contain the 3D-coordinates of the mark points , polygons's ids which are formed by marked points, indicator for the operation(digging/dumping)

# Unity scene
The project is located within the `WorldMarkPosition/SetPosition` Unity scene.


## Useful links

[World Locking Tools Samples github repo](https://github.com/microsoft/MixedReality-WorldLockingTools-Samples).

[Google drive of the whole unity document](https://drive.google.com/file/d/1zVV_ax-EhPET7Ulag0wUSd9AeBTiaMqo/view?usp=sharing).

[video demo on youtube](https://youtu.be/2GUs8d7U5sY)



## Specified functions
1.align the virtual scene with the physical world Microsofts World locking tools framework is used. see above link World Locking Tools Samples.

2.Placement and visualization of points (see 'CreaterPoint.cs').

3.Function for editing point in x,y,z (see 'NearinteractionGrabbable.cs' from the MRTK package).

4.Indicator for z-height above/below terrain(see 'ObjectManipulator.cs' from MRTK package).

5.Possibility to draw multiple polygons(see 'strucPointData.cs' and 'CancellatedStructure.cs').

6.Possibility to draw different types of polygons(see 'SetMark.cs').

7.Export as CSV (see 'Csv.cs').








