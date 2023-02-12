# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

 - Vector2AnimatorParameter: Manipulates pairs of float parameters in Animators as Vector2s.
 - Vector3AnimatorParameter: Manipulates triples of float parameters in Animators as Vector3s.
 - IntegerVector2AnimatorParameter: Manipulates pairs of integer parameters in Animators as Vector2Ints.
 - IntegerVector3AnimatorParameter: Manipulates triples of integer parameters in Animators as Vector3Ints.

### Fixed

 - Fixed IntegerAnimatorParameter showing in the wrong add component submenu.

## [0.1.0] - 2023-02-12

### Added 

 - AnimatorParameter: An abstract base class which links with an Animator and manipulates a named parameter.
 - IntegerAnimatorParameter: Manipulates integer parameters in Animators.
 - FloatAnimatorParameter: Manipulates float parameters in Animators.
 - BooleanAnimatorParameter: Manipulates boolean parameters in Animators.
 - TriggerAnimatorParameter: Manipulates trigger parameters in Animtors as booleans.
