#include "pch.h"
#include "petrov_item.h"
#include "petrov_used_item.h"
#include "petrov_shop.h"

#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include <memory>
#include <stdexcept>
#include <iostream>
#include <cstring>

using namespace std;

struct item_struct {
	char name[256];
	double weight;
	double width;
	double height;
	int price;
	bool stock;

	int age;
	double condition;
	char description[256];
};

shop s;

extern "C" __declspec(dllexport) void __stdcall shop_read(const char* filename) {
	s.shop_read(filename);
}

extern "C" __declspec(dllexport) const char* shop_write(const char* filePath) {
	s.shop_write(filePath);
}


extern "C" __declspec(dllexport) void shop_get_item(item_struct& item_data, int id) {
	if (id < 0 || id >= s.get_size()) return;
	auto current_item = s.get(id);

	strcpy_s(item_data.name, current_item->get_name().c_str());
	item_data.weight = current_item->get_weight();
	item_data.width = current_item->get_width();
	item_data.height = current_item->get_height();
	item_data.price = current_item->get_price();
	item_data.stock = current_item->get_stock();

	auto used_item_ptr = dynamic_pointer_cast<used_item>(current_item);
	if (used_item_ptr) {
		item_data.age = used_item_ptr->get_age();
		item_data.condition = used_item_ptr->get_condition();
		strcpy_s(item_data.description, used_item_ptr->get_description().c_str());
	}
}

extern "C" __declspec(dllexport) void __stdcall shop_update_item(const item_struct& item_data, int id) {
	if (id < 0 || id >= s.get_size()) return;

	auto current_item = s.get(id);

	current_item->set_name(item_data.name);
	current_item->set_weight(item_data.weight);
	current_item->set_width(item_data.width);
	current_item->set_height(item_data.height);
	current_item->set_price(item_data.price);
	current_item->set_stock(item_data.stock);

	auto used_item_ptr = dynamic_pointer_cast<used_item>(current_item);
	if (used_item_ptr) {
		used_item_ptr->set_age(item_data.age);
		used_item_ptr->set_condition(item_data.condition);
		used_item_ptr->set_description(item_data.description);
	}
}

extern "C" __declspec(dllexport) void __stdcall shop_add_item(const item_struct& item_data, int is_used) {
	shared_ptr<item> new_item;

	if (is_used == 1) { 
		auto used_item_ptr = make_shared<used_item>();

		used_item_ptr->set_name(item_data.name);
		used_item_ptr->set_weight(item_data.weight);
		used_item_ptr->set_width(item_data.width);
		used_item_ptr->set_height(item_data.height);
		used_item_ptr->set_price(item_data.price);
		used_item_ptr->set_stock(item_data.stock);
		used_item_ptr->set_age(item_data.age);
		used_item_ptr->set_condition(item_data.condition);
		used_item_ptr->set_description(item_data.description);

		new_item = used_item_ptr;
	}
	else {
		auto normal_item_ptr = make_shared<item>();

		normal_item_ptr->set_name(item_data.name);
		normal_item_ptr->set_weight(item_data.weight);
		normal_item_ptr->set_width(item_data.width);
		normal_item_ptr->set_height(item_data.height);
		normal_item_ptr->set_price(item_data.price);
		normal_item_ptr->set_stock(item_data.stock);

		new_item = normal_item_ptr;
	}

	s.shop_add(new_item);
}

extern "C" __declspec(dllexport) int GetShopSize() {
	return s.get_size();
}

extern "C" __declspec(dllexport) void ClearShop() {
	s.clear();
}

extern "C" __declspec(dllexport) void shop_delete(int id)
{
	s.shop_delete(id);
}


BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
	switch (ul_reason_for_call) {
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}
