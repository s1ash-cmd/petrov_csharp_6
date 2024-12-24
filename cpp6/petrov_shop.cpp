#include "pch.h"
#include "petrov_shop.h"

#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include <memory>
#include <stdexcept>
#include <iostream>

using namespace std;

void shop::shop_read(const string& filename) {
	ifstream fin(filename);

	boost::archive::text_iarchive ia(fin);
	items.clear();
	ia >> items;

	fin.close();
}

void shop::shop_write(const string& filename) {
	ofstream fout(filename);

	boost::archive::text_oarchive oa(fout);
	oa << items;

	fout.close();
}


void shop::clear() {
	items.clear();
}

int shop::get_size() const {
	return items.size();
}

void shop::shop_add(shared_ptr<item> item) {
	items.push_back(item); 
}

void shop::shop_delete(int id) {
	items.erase(items.begin() + id);
}

shared_ptr<item> shop::get(int i) {
	return items[i];
}

