-- Hospital Management System Database Setup
-- Run this script in MySQL (XAMPP)

CREATE DATABASE IF NOT EXISTS hospital_db;
USE hospital_db;

-- Patients Table
CREATE TABLE IF NOT EXISTS patients (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    age INT NOT NULL,
    gender VARCHAR(10),
    phone VARCHAR(20),
    medical_history TEXT
);

-- Doctors Table
CREATE TABLE IF NOT EXISTS doctors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    specialty VARCHAR(100) NOT NULL,
    phone VARCHAR(20)
);

-- Appointments Table
CREATE TABLE IF NOT EXISTS appointments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    FOREIGN KEY (patient_id) REFERENCES patients(id),
    FOREIGN KEY (doctor_id) REFERENCES doctors(id)
);

-- Billing Table
CREATE TABLE IF NOT EXISTS billing (
    id INT AUTO_INCREMENT PRIMARY KEY,
    patient_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    payment_status VARCHAR(20) NOT NULL,
    billing_date DATE NOT NULL,
    FOREIGN KEY (patient_id) REFERENCES patients(id)
);

-- Sample Data
INSERT INTO patients (name, age, gender, phone, medical_history) VALUES 
('John Doe', 45, 'Male', '1234567890', 'Diabetes'),
('Jane Smith', 32, 'Female', '0987654321', 'Hypertension');

INSERT INTO doctors (name, specialty, phone) VALUES 
('Dr. Robert Brown', 'Cardiologist', '1112223333'),
('Dr. Emily White', 'General Physician', '4445556666');
