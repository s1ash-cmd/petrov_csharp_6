#pragma once

#include "pch.h"

#include <string>

using namespace std;

class item {
protected:
	string name = "";
	double weight = 0.0;
	double width = 0.0;
	double height = 0.0;
	int price = 0;
	bool stock = 0;

public:
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

	string get_name() const { return name; }
	double get_weight() const { return weight; }
	double get_width() const { return width; }
	double get_height() const { return height; }
	int get_price() const { return price; }
	bool get_stock() const { return stock; }

	void set_name(const string& name) { this->name = name; }
	void set_weight(const double& weight) { this->weight = weight; }
	void set_width(const double& width) { this->width = width; }
	void set_height(const double& height) { this->height = height; }
	void set_price(const int& price) { this->price = price; }
	void set_stock(const bool& stock) { this->stock = stock; }
};