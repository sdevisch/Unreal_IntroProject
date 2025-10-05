// Copyright Epic Games, Inc. All Rights Reserved.

#include "IntroCppGameMode.h"
#include "IntroCppCharacter.h"
#include "UObject/ConstructorHelpers.h"

AIntroCppGameMode::AIntroCppGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
