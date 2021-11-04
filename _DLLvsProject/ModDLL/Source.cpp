#define EXPORT_API __declspec(dllexport)

//real dll
#include <random>
#include <time.h>

// Link following functions C-style (required for plugins)
extern "C"
{
	struct Vector3 {
		float x;
		float y;
		float z;
	};
	
	float EXPORT_API getMaxHP()
	{
		return 10;
	}

	float EXPORT_API getSpeed()
	{
		return 10;
	}

	float EXPORT_API getDamage()
	{
		return 1;
	}

	float EXPORT_API getHPup()
	{
		return 5;
	}

	float EXPORT_API getEnemyDamage()
	{
		return 2;
	}

	float EXPORT_API getEnemySpeed()
	{
		return 6;
	}

	float EXPORT_API getEnemyHP()
	{
		return 3;
	}
	
}