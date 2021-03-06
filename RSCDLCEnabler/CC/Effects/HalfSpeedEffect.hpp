#pragma once
#include "../CCEffect.hpp"
#include "../CCEffectList.hpp"

namespace CrowdControl::Effects {
	class HalfSpeedEffect : public CCEffect
	{
	public:
		HalfSpeedEffect(unsigned int durationSeconds) {
			duration = durationSeconds;
		}

		EffectResult Test(Request request);
		EffectResult Start(Request request);
		void Run();
		EffectResult Stop();

	private:
		std::vector<std::string> incompatibleEffects =
			{ "doublesongspeed" };
	};
}

#pragma once
