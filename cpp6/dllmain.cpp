#include "pch.h"
#include <boost/archive/text_iarchive.hpp>
#include <boost/archive/text_oarchive.hpp>
#include <boost/serialization/base_object.hpp>
#include <boost/serialization/export.hpp>
#include <boost/serialization/serialization.hpp>
#include <boost/serialization/shared_ptr.hpp>
#include <boost/serialization/string.hpp>
#include <boost/serialization/vector.hpp>

#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include <memory>
#include <stdexcept>
#include <iostream>

using namespace std;

class item {
public:
	string name = "";
	double weight = 0.0;
	double width = 0.0;
	double height = 0.0;
	int price = 0;
	bool stock = 0;

	virtual ~item() = default;

	template <class Archive>
	void serialize(Archive& ar, const unsigned int version) {
		ar& name;
		ar& weight;
		ar& width;
		ar& height;
		ar& price;
		ar& stock;
	}
};

class used_item : public item {
public:
	int age = 0;
	double condition = 0.0;
	string description = "";

	template <class Archive>
	void serialize(Archive& ar, const unsigned int version) {
		ar& boost::serialization::base_object<item>(*this);
		ar& age;
		ar& condition;
		ar& description;
	}
};

class shop {
public:
	vector<shared_ptr<item>> items;

	void items_read(const string& filename);

};


void shop::items_read(const string& filename) {
	ifstream fin(filename);
	if (!fin) {
		cerr << "Невозможно открыть файл: " << filename << endl;
		return;
	}

	try {
		boost::archive::text_iarchive ia(fin);
		ia >> items;
	}
	catch (const exception& e) {
		cerr << "Ошибка чтения из файла: " << e.what() << endl;
	}

	fin.close();
}



extern "C" __declspec(dllexport) const char* items_read(const char* filePath) {
	static string result;  // Статическая строка для хранения результата

	shop s;
	try {
		s.items_read(filePath);

		// Проверяем, что в контейнере есть товары
		if (!s.items.empty()) {
			result = "Первый товар: " + s.items[0]->name;  // Выводим название первого товара
		}
		else {
			result = "Товары не найдены в файле.";
		}
	}
	catch (const exception& e) {
		result = "Ошибка: " + string(e.what());  // Возвращаем строку с ошибкой
	}

	return result.c_str();  // Возвращаем указатель на строку
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
