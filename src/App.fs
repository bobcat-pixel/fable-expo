module App

module R = Fable.ReactNative.Helpers
module P = Fable.ReactNative.Props

open Fable.Core
open Fable.ReactNative.Props

let app () =
    R.view [] [
        R.text [] "This is the happy home screen"
    ]
