#pragma once

#include "pch.h"
#include "petrov_item.h"

using namespace std;

class used_item : public item {
protected:
    int age = 0;
    double condition = 0.0;
    string description = "";

public:
    template <class Archive>
    void serialize(Archive& ar, const unsigned int version) {
        ar& boost::serialization::base_object<item>(*this);
        ar& age;
        ar& condition;
        ar& description;
    }

    int get_age() const { return age; }
    double get_condition() const { return condition; }
    string get_description() const { return description; }

    void set_age(const int& age) { this->age = age; }
    void set_condition(const double& condition) { this->condition = condition; }
    void set_description(const string& description) { this->description = description; }
};