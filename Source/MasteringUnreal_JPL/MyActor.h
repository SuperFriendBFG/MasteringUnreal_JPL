// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/Actor.h"
#include "MyActor.generated.h"

UCLASS()
class MASTERINGUNREAL_JPL_API AMyActor : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AMyActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;


	// Adds Message Property to the Class
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category="MyActor")
		FString message;

	// Enables Callable Printed Messages
	UFUNCTION(BlueprintCallable, Category = "MyActor")
		void PrintMessage();
	
	
};
