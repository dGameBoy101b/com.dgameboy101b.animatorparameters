# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

 - **Color Animator Parameter**: Manipulates quadruples of float parameter in Animators as Colors.
 - **Vector4 Animator Parameter**: Manipulates quadruples of float parameters in Animaters as Vector4s.

### Fixed

 - Fixed animator parameters showing the wrong name in the inspector.

## [0.2.0] - 2023-02-12

### Added

 - **Vector2 Animator Parameter**: Manipulates pairs of float parameters in Animators as Vector2s.
 - **Vector3 Animator Parameter**: Manipulates triples of float parameters in Animators as Vector3s.
 - **Integer Vector2 Animator Parameter**: Manipulates pairs of integer parameters in Animators as Vector2Ints.
 - **Integer Vector3 Animator Parameter**: Manipulates triples of integer parameters in Animators as Vector3Ints.

### Fixed

 - Fixed Integer Animator Parameter showing in the wrong add component submenu.

## [0.1.0] - 2023-02-12

### Added 

 - **Animator Parameter**: An abstract base class which links with an Animator and manipulates a named parameter.
 - **Integer Animator Parameter**: Manipulates integer parameters in Animators.
 - **Float Animator Parameter**: Manipulates float parameters in Animators.
 - **Boolean Animator Parameter**: Manipulates boolean parameters in Animators.
 - **Trigger Animator Parameter**: Manipulates trigger parameters in Animtors as booleans.
