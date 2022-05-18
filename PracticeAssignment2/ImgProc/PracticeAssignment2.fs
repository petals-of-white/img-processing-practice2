module PracticeAssignment2

open Emgu.CV
open Emgu.CV.Structure
open Emgu.CV.CvEnum
open Emgu.CV.Util
open System.Drawing

/// Створює необхідне зображення
let createTaskImg () =
    let size = new Size(100, 100)
    let square = new Rectangle(20, 20, 60, 60)

    let whiteSqr = new Mat(size, DepthType.Cv32F, 1)
    whiteSqr.SetTo(new MCvScalar(0))

    CvInvoke.Rectangle(whiteSqr, square, new MCvScalar(1), -30)

    whiteSqr

/// Об'єднує три канали
let merge ch1 ch2 ch3 =
    let rgb = new VectorOfMat(ch3, ch2, ch1)

    let mergedMat = new Mat()
    CvInvoke.Merge(rgb, mergedMat)

    mergedMat
